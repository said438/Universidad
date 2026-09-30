const btnObtenerInfo = document.querySelector("#btnObtenerInfo")
const resultadoInfo =  document.querySelector("#resultadoInfo")

async function obtenerProvinciasDesdeApi () {
    try {
        const resultado = await fetch("https://apis.datos.gob.ar/georef/api/provincs")
        const json = await resultado.json()
        return json
    } catch (error) {
        console.error(error)
    }
}

btnObtenerInfo.addEventListener("click", async () => {
    const resultadoApi = await obtenerProvinciasDesdeApi()
    console.log(resultadoApi)
    let elementosNuevos = "";
    resultadoApi.provincias.forEach((elem) => {
        elementosNuevos += `
            <div>${elem.nombre}</div>
        `
    })
    resultadoInfo.innerHTML = elementosNuevos;

})