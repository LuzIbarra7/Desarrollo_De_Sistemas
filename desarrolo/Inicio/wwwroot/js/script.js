document.addEventListener('DOMContentLoaded', () => {
    // Obtener referencias a la entrada de contraseña y al botón de alternar
    const passwordInput = document.getElementById('Password'); // Nota: el ID coincide con el nombre de la propiedad C#
    const togglePasswordButton = document.querySelector('.toggle-password');
  
    // Verificar si el botón de alternar y la entrada de contraseña existen antes de añadir oyentes de eventos
    if (togglePasswordButton && passwordInput) {
      // Añadir un oyente de eventos de clic al botón de alternar visibilidad de contraseña
      togglePasswordButton.addEventListener('click', () => {
        // Determinar el nuevo tipo para la entrada de contraseña (texto o contraseña)
        const type = passwordInput.getAttribute('type') === 'password' ? 'text' : 'password';
        // Establecer el nuevo atributo de tipo en la entrada de contraseña
        passwordInput.setAttribute('type', type);
  
        // Cambiar el icono y actualizar aria-label para accesibilidad
        // Si el tipo es 'password', mostrar el icono 'ojo' (👁️) y establecer aria-label en 'Mostrar contraseña'
        // Si el tipo es 'text', mostrar el icono 'ojo oculto' (🙈) y establecer aria-label en 'Ocultar contraseña'
        togglePasswordButton.textContent = type === 'password' ? '👁️' : '🙈';
        togglePasswordButton.setAttribute('aria-label', type === 'password' ? 'Mostrar contraseña' : 'Ocultar contraseña');
      });
    }
  
    // Nota: El envío del formulario ahora se maneja principalmente por el código C# del lado del servidor.
    // El JavaScript del lado del cliente para el envío del formulario (como la alerta anterior) se elimina
    // porque la retroalimentación provendrá del servidor a través de Model.Message.
    // Si necesitas validación del lado del cliente o envío AJAX, lo añadirías aquí.
  });
  