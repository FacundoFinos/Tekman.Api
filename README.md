# Tekman.Api
Prueba técnica - BackEnd

* Implementación:
  - Para la implementación de la API se utilizó el almacenamiento en memoria que brinda entity framework core. Ningun dato es persitente cuando se interrumpe la ejecución.
  - Se utilizaron clases para modelar las tablas de la base de datos y sus relaciones. Extrapolado a una base de datos, se requeririan varias tablas mas para modelar las relaciones.
  - Existen datos cargados de antemano, la inicialización de los mismos se realiza en la clase DataGenerator.cs del proyecto Repository.
  - La estructura de la API se divide en 4, API, Infrastructure, Repository, Service.
  - Para el manejo de excepciones se creó un filter de excepciones, el siguiente paso es crear clases que manejen estas exepciones.
  - El cálculo de las notas es una división entre el resultado de respuestas correctas/total de respuestas, multiplicado por 10.
  
* Pruebas:
  - Para probar la API se debe descargar el codigo, ejecutarlo y correr en el Postman los servicios adjuntos por mail.
  - Existen datos pre-cargados por codigo.
