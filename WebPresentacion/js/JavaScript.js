function SweetAlert(titulo, men, tipo) {
    Swal.fire({
        title: titulo,
        text: men,
        icon: tipo,
        confirmButtonText: 'Aceptar'
    })
}