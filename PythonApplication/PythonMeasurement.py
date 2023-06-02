# import the necessary packages
from scipy.spatial import distance as dist
from imutils import perspective
from imutils import contours
import numpy as np
import imutils
import math
import cv2

# mm per pixel
irate = 0.0208

def midpoint(ptA, ptB):
	return ((ptA[0] + ptB[0]) * 0.5, (ptA[1] + ptB[1]) * 0.5)

delta = 6

def nearest_to_average(arr):
    average = sum(arr)/ len(arr) # tính trung bình cộng của mảng
    nearest = min(arr, key= lambda x: abs(x - average)) # tìm phần tử gần nhất với trung bình cộng
    return nearest

def build_line(x1, y1, x2, y2):
    dx = abs(x2 - x1)
    dy = abs(y2 - y1)
    sx = 1 if x1 < x2 else -1
    sy = 1 if y1 < y2 else -1
    err = dx - dy

    x, y = x1, y1
    points = []

    while True:
        points.append((x, y))

        if x == x2 and y == y2:
            break

        e2 = 2 * err

        if e2 > -dy:
            err -= dy
            x += sx

        if e2 < dx:
            err += dx
            y += sy

    return points

def polar_coordinates_on_circle(x, y, r):
    points = []
    for angle in range(0, 360):
        i = x + r * math.cos(math.radians(angle))
        j = y + r * math.sin(math.radians(angle))
        points.append((i,j))
    return points

def measurement(imgPath):
	image = cv2.imread(imgPath)
	scale_percent = 30 # percent of original size
	width = int(image.shape[1] * scale_percent / 100)
	height = int(image.shape[0] * scale_percent / 100)
	dim = (width, height) #px
	# print(dim)
	gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
	blur = cv2.GaussianBlur(gray, (7, 7), 0)
	# cv2.imshow(cv2.resize(gray, dim, interpolation = cv2.INTER_AREA))
	edged = cv2.Canny(blur,70,150)
	edged = cv2.dilate(edged, None, iterations=1)
	edged = cv2.erode(edged, None, iterations=1)
	# cv2.imshow(cv2.resize(edged, dim, interpolation = cv2.INTER_AREA))
	cnts = cv2.findContours(edged.copy(), cv2.RETR_EXTERNAL,
	cv2.CHAIN_APPROX_SIMPLE)
	cnts = imutils.grab_contours(cnts)
	(cnts, _) = contours.sort_contours(cnts)
	for c in cnts:
	# if the contour is not sufficiently large, ignore it
	# Bỏ qua đường viền có diện tích nhỏ 
		if cv2.contourArea(c) < 1000:
			continue
	# compute the rotated bounding box of the contour
	# Xác định hình chữ nhật nhỏ nhất bao quanh vật thể 
		orig = image.copy()
	# orig = edged.copy()
		box = cv2.minAreaRect(c)
    # Xác định hình tròn nhỏ nhất quanh vật thể 
		(x_r, y_r), radius = cv2.minEnclosingCircle(c)
		center = (int(x_r), int(y_r))
		radius = int(radius)
		# print("R = ", radius)
		# print(center)
		# Draw outside circle
		# Vẽ đường tròn ngoài 
		# cv2.circle(orig, center, radius, (0,255,0), 2)
		x_start_point = x_r - radius 
		x_endpoint = x_r + radius 
		# draw outside circle diameter
		# Vẽ đường kính ngoài 
		# cv2.line(orig, (int(x_start_point),int(y_r)),(int(x_endpoint), int(y_r)), (0, 0, 255), 10)
		# cv2.line(orig, (int(x_r),int(y_r)),(int(x_endpoint), int(y_r)), (0, 0, 255), 10)
		cv2.arrowedLine(orig, (int(x_r), int(y_r)), (int(x_endpoint), int(y_r)),
	                (255, 0, 255), 10)
		cv2.arrowedLine(orig, (int(x_r), int(y_r)), (int(x_r - radius), 
			int(y_r)), (255, 0, 255), 10)
	# draw_radius(orig, int(x_r), int(y_r))
		angle_degrees =   45
		angle_radians = np.deg2rad(angle_degrees)
	
		for i in range(int(x_r), orig.shape[1]):
			if y_r >= 0 and y_r < orig.shape[1]:
				if edged[int(y_r)][i] == 255:
					# print("i", i)
					# draw inside circle endpoints
					cv2.circle(orig, (i, int(y_r)), 10, (255, 0, 255), -1)
					inside_radius = i - x_r
					print("R in(px): ", inside_radius)
					x_endpoint_i = int(x_r + inside_radius * np.cos(angle_radians))
					y_endpoint_i = int(y_r + inside_radius * np.sin(angle_radians))
					x_startpoint = int(2*x_r - x_endpoint_i)
					y_startpoint = int(2*y_r - y_endpoint_i)
					# Draw the inside circle
					# Vẽ phần đường tròn trong 
					cv2.circle(orig, center, int(inside_radius), (0,255,0), 2)
				  # draw inside circle diameter
      		# Vẽ đường kính trong  
					# cv2.line(orig, (int(x_startpoint), int(y_startpoint))
					# ,(int(x_endpoint_i), int(y_endpoint_i)), (255, 0, 255), 10)
					cv2.arrowedLine(orig, (int(x_r), int(y_r))
					, (int(x_endpoint_i), int(y_endpoint_i)), (255, 0, 255), 10)
					cv2.arrowedLine(orig, (int(x_r), int(y_r))
					, (int(x_startpoint), int(y_startpoint)), (255, 0, 255), 10)
		
					break

	# Hiển thị kích thước trên ảnh 
		print("R out(px): ", radius)
		# Condition
		file_path = 'Imageresult.txt'

		if(radius * irate >= 23.7 and radius * irate <= 24.3):
			print(imgPath + " OK")
			return "OK"
			with open(file_path, 'w') as file:
				file.write(imgPath + " OK" + '\n')
		else:
			print(imgPath + " NG")
			return "NG"
			with open(file_path, 'w') as file:
				file.write(imgPath + " NG" + '\n')

		# Draw the center point
		# Vẽ tâm 
		cv2.circle(orig, center, 17, (0, 255, 0), -1)
		cv2.putText(orig, "Inside radius: {} mm".format(inside_radius * irate),
				(30,200), cv2.FONT_HERSHEY_SIMPLEX,
				3, (255, 0, 0), 2)
		cv2.putText(orig, "Outside radius: {} mm".format(radius * irate),
	 			(30, 300), cv2.FONT_HERSHEY_SIMPLEX,
				3, (255, 0, 0), 2)
		box = cv2.cv.BoxPoints(box) if imutils.is_cv2() else cv2.boxPoints(box)
		box = np.array(box, dtype="int")
  
		# order the points in the contour such that they appear
		# in top-left, top-right, bottom-right, and bottom-left
		# order, then draw the outline of the rotated bounding
		# box
		box = perspective.order_points(box)
		# loop over the original points and draw them
		# between the top-left and top-right coordinates, followed by
		# the midpoint between bottom-left and bottom-right coordinates
		(tl, tr, br, bl) = box
		edgedArr = []

		for i in range(int(x_r), int(orig.shape[1])):
			if i >= 0 and i < 2748:
				if edged[int(y_r), i] == 255:
					edgedArr.append(i)
		print(edgedArr)

		# detect err 
		checkArr = []
	
		for i in range(360):
			angle = math.radians(i)
			r = int(edgedArr[3] - x_r)
			x = int(x_r + r * math.cos(angle))
			y = int(y_r + r * math.sin(angle))
			# if i:
			# 	cv2.line(orig, (int(x), int(y)),
			# 	(int(x + (edgedArr[2] - edgedArr[1])),
			# 	int(y + (edgedArr[2] - edgedArr[1]))), (0,0, 255), 3)
			delta = 6 

			for jx, jy in build_line(x + 1, y + 1, x + (edgedArr[3] - edgedArr[2])
			 - 1, y + (edgedArr[3] - edgedArr[2]) -1):
				if edged[jx][jy] == 255:
					# print("Error in {}, {}", jx, jy)
					if edged[jx + delta][jy + delta]:
						# print("Error in {}, {}", jx, jy)
						cv2.circle(orig, (int(jx), int(jy)), 38, (0, 0, 255), 3)
						checkArr.append((jx, jy))
					
		if(len(checkArr)):
			print(checkArr)
			count = {}
			for x, y in checkArr:
				if x in count:
					count[x] += 1
				else:
					count[x] = 1
		max_count = max(count.values())
		most_frequent_x = [x for x, c in count.items() if c == max_count]
		sorted_arr = sorted(most_frequent_x)
		nearest = nearest_to_average(sorted_arr)
		# print(nearest)
		y_nearest = 0
		for x, y in checkArr:
			if x == nearest:
				y_nearest = y
		(tltrX, tltrY) = midpoint(tl, tr)
		(blbrX, blbrY) = midpoint(bl, br)
		# compute the midpoint between the top-left and top-right points,
		# followed by the midpoint between the top-righ and bottom-right
		(tlblX, tlblY) = midpoint(tl, bl)
		(trbrX, trbrY) = midpoint(tr, br)

		# draw the midpoints on the image
		cv2.circle(orig, (int(tltrX), int(tltrY)), 5, (255, 0, 0), -1)
		cv2.circle(orig, (int(blbrX), int(blbrY)), 5, (255, 0, 0), -1)
		cv2.circle(orig, (int(tlblX), int(tlblY)), 5, (255, 0, 0), -1)
		cv2.circle(orig, (int(trbrX), int(trbrY)), 5, (255, 0, 0), -1)
		cv2.imshow(cv2.resize(orig, dim, interpolation = cv2.INTER_AREA))
		cv2.imwrite(imgPath.replace(".jpeg", "_measure_result.jpeg"), orig)
		cv2.waitKey(0)