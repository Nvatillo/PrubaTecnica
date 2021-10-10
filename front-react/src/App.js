import "./App.css";
import { useState, useEffect } from "react";
import "bootstrap/dist/css/bootstrap.min.css";
function App() {
  const [listaPersonas, setListaPersonas] = useState([]);
  const [modalInsertar, setModalInsertar] = useState(false);

  useEffect(() => {
    fetch("https://localhost:44332/personas")
      .then((response) => response.json())
      .then((res) => setListaPersonas(res));
  }, []);

  function modalMostrar() {
    setModalInsertar(!modalInsertar);
  }

  return (
    <div className="App d-flex justify-content-center">
      <div className="w-75">
        <button className="btn btn-success mt-1 " onClick={modalMostrar}>
          Agregar Persona
        </button>
        <table className="table mt-3 ">
          <thead>
            <tr>
              <th>Nombre</th>
              <th>Run</th>
              <th></th>
            </tr>
          </thead>
          <tbody>
            {listaPersonas &&
              listaPersonas.map((persona, index) => {
                return (
                  <tr key={index}>
                    <td>{persona.nombre}</td>
                    <td>{persona.run}</td>
                    <td>
                      <button className="btn btn-primary">Editar</button>{" "}
                      <button className="btn btn-danger">Borrar</button>
                    </td>
                  </tr>
                );
              })}
          </tbody>
        </table>
      </div>
    </div>
  );
}

export default App;
