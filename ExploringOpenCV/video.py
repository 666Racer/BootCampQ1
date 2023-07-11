import cv2

face_cascades = cv2.CascadeClassifier(cv2.data.haarcascades + "haarcascade_frontalface_default.xml") #xml на поиск лица

# img = cv2.imread('C:/Users/user/Desktop/Other stuff/Ed-stuff/GB/face.jpg')
# img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# faces = face_cascades.detectMultiScale(img_gray)
# # print (faces) # прямогуольник, внутри котрого лицо

# for (x, y, w, h) in faces:
#     cv2.rectangle(img, (x, y), (x + w, y + h), (255, 0, 0), 2)


# cv2.imshow('Result', img)
# cv2.waitKey(0)

cap = cv2.VideoCapture(0)

while True:
    _, frame = cap.read()
    img_gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    faces = face_cascades.detectMultiScale(img_gray) #делаем серым

    for (x, y, w, h) in faces:
        cv2.rectangle(frame, (x, y), (x + w, y + h), (255, 0, 0), 2)

    cv2.imshow('Result', frame)

    if cv2.waitKey(1) & 0xff == ord('q'):
        break
