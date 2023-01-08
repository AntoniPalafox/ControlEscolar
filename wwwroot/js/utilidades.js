//Consultar una API (GET) y mandar el resultado como json a una funcion
export async function consultarAPI(url, funcion){
    
    try {
        const resultado = await fetch(url);
        const data = await resultado.json();
        funcion(data);
    } catch (error) {
        console.log(error);
    }
}