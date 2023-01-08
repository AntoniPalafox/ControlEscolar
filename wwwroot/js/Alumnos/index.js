import { consultarAPI } from "../utilidades.js";

(function(){
    console.log("vinculado con éxito");
    $(document).ready( function () {
        $('#tabla-alumnos').DataTable({
            "language": {
                "url": "//cdn.datatables.net/plug-ins/1.12.1/i18n/es-ES.json"
            },
            dom: 'Bfrtip'
        });
    } );

    consultarAPI("/Alumnos/ConsultaAlumnos", console.log)
})();