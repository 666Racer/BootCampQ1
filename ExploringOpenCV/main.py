import cv2 #OpenCV работает с BGR, а не RGB!

img = cv2.imread('C:/Users/user/Desktop/Other stuff/Ed-stuff/GB/test.jpg')

img = cv2.resize(img, (500, 500))
#print (img.shape)

cv2.imshow('Result', img)

cv2.waitKey(0)