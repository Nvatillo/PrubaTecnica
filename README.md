# Prueba Tecnica

## Frontend

Para ejecutar el front ejecutar un npm install .

NOTA: Solo realize el listar.


## Backend

La api cuenta con los siguientes endpoints 

* Obtener personas
  * `curl -X GET "https://localhost:44332/personas" -H  "accept: application/json" `
* Guardar persona
  * `curl -X POST "https://localhost:44332/personas" -H  "accept: */*" -H  "Content-Type: application/json" -d "{\"id\":\"3fa85f64-5717-4562-b3fc-2c963f66afa6\",\"run\":\"19305272-k\",\"nombres\":\"Francisco Antonio\",\"apellidoPaterno\":\"Gajardo\",\"apellidoMaterno\":\"Perez\",\"email\":\"francisco.gajardo@gmai.com\",\"sexoCodigo\":1,\"fechaNacimiento\":\"2021-10-10T23:51:15.021Z\",\"regionCodigo\":1,\"ciudadCodigo\":1,\"comunaCodigo\":1,\"direccion\":\"Los aperos\",\"telefono\":979318137,\"observaciones\":\"sin observaciones\"}" `
* Buscar persona por Guid
  * `curl -X GET "https://localhost:44332/personas/{guid}" -H  "accept: application/json" ` 
* Editar persona 
  * `curl -X PUT "https://localhost:44332/personas/{guid}" -H  "accept: */*" -H  "Content-Type: application/json" -d "{\"id\":\"3fa85f64-5717-4562-b3fc-2c963f66afa6\",\"run\":\"19305272-k\",\"runCuerpo\":19305272,\"runDigito\":\"k\",\"nombre\":\"Francisco\",\"nombres\":\"Francisco Antonio\",\"apellidoPaterno\":\"Gajardo\",\"apellidoMaterno\":\"Perez\",\"email\":\"f@gmail.com\",\"sexoCodigo\":1,\"fechaNacimiento\":\"2021-10-10T23:57:15.426Z\",\"regionCodigo\":1,\"ciudadCodigo\":1,\"comunaCodigo\":1,\"direccion\":\"los aperos\",\"telefono\":979318137,\"observaciones\":\"sin observaciones\"}"`
* Eliminar persona
  * `curl -X DELETE "https://localhost:44332/personas/{guid}" -H  "accept: */*"` 
* Obtener regiones, ciudad y comuna
  * `curl --location --request GET 'https://localhost:44332/regiones'` 


