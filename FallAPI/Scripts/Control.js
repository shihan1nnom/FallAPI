let app = document.getElementById('root');

let tabla = document.getElementById('tabla');
app.appendChild(tabla);

// Crear una variable de solicitud y asignarle un nuevo objeto  XMLHttpRequest
var request = new XMLHttpRequest();

// Abrir una nueva conexión, utilizando la solicitud GET en el punto final de la URL
function find() {
    request.open('GET', '../cancelaciones', true);
    var data = JSON.parse(this.response);
}

request.onload = function () {
    

    if (request.status >= 200 && request.status < 400) {
        let thead = document.createElement('thead');
        tabla.appendChild(thead);
        let tr = document.createElement('tr');
        thead.appendChild(tr);
        tr.setAttribute('class', 'text-center');
        let th1 = document.createElement('th');
        th1.textContent = "Cedula";
        tr.appendChild(th1);
        let th2 = document.createElement('th');
        th2.textContent = "OC";
        tr.appendChild(th2);
        let th3 = document.createElement('th');
        th3.textContent = "F12";
        tr.appendChild(th3);
        let th4 = document.createElement('th');
        th4.textContent = "SKU";
        tr.appendChild(th4);
        let th5 = document.createElement('th');
        th5.textContent = "Estado F12";
        tr.appendChild(th5);
        let th6 = document.createElement('th');
        th6.textContent = "X # entrega";
        tr.appendChild(th6);
        let th7 = document.createElement('th');
        th7.textContent = "Comentarios";
        tr.appendChild(th7);

        let tbody = document.createElement('tbody');
        tabla.appendChild(tbody);

        var buscar = document.getElementById('buscar').value;

        data.forEach((cancelaciones) => {
            if (buscar == cancelaciones.f12) {
                const tr1 = document.createElement('tr');
                tbody.appendChild(tr1);
                tr1.setAttribute('class', 'text-center');

                const td2 = document.createElement('td');
                td2.textContent = "1234567";
                tr1.appendChild(td2);

                const td1 = document.createElement('td');
                td1.textContent = cancelaciones.oc;
                tr1.appendChild(td1);

                const td3 = document.createElement('td');
                td3.textContent = cancelaciones.f12;
                tr1.appendChild(td3);

                const td4 = document.createElement('td');
                td4.textContent = "";
                tr1.appendChild(td4);

                const td5 = document.createElement('td');
                td5.textContent = cancelaciones.estado_linea;
                tr1.appendChild(td5);

                const td6 = document.createElement('td');
                td6.textContent = "";
                tr1.appendChild(td6);

                const td7 = document.createElement('td');
                td7.textContent = "";
                tr1.appendChild(td7);
            }
        });
    } else {
        const errormessage = document.createElement('marquee');
        errormessage.textContent = 'Problemas en la pagina web, lo sentimos';
        app.appendChild(errormessage);
    }

}

request.send();