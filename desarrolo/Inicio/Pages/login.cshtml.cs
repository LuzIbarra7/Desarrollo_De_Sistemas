using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations; // Para anotaciones de datos como [Required]

namespace Inicio.Pages // ¡NAMESPACE AJUSTADO A 'Inicio.Pages'!
{
    public class LoginModel : PageModel
    {
        // Propiedades para enlazar a las entradas del formulario
        [BindProperty] // Este atributo habilita el enlace de modelo para esta propiedad
        [Required(ErrorMessage = "El correo electrónico es obligatorio.")] // Validación del lado del servidor
        [EmailAddress(ErrorMessage = "Formato de correo electrónico inválido.")] // Validación de formato de correo
        public string Email { get; set; } = ""; // Inicializar para evitar advertencias de referencia nula

        [BindProperty]
        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [DataType(DataType.Password)] // Especifica que este campo contiene datos de contraseña
        public string Password { get; set; } = "";

        // Propiedad para contener mensajes a mostrar al usuario
        public string Message { get; set; } = "";

        // Maneja las solicitudes GET a la página (ej. cuando se carga la página por primera vez)
        public void OnGet()
        {
            // Puedes añadir lógica aquí si es necesario cuando se carga la página
            // Por ejemplo, pre-llenar campos o verificar sesiones existentes.
        }

        // Maneja las solicitudes POST a la página (ej. cuando se envía el formulario)
        public async Task<IActionResult> OnPostAsync()
        {
            // Verificar si el estado del modelo es válido según las anotaciones de datos
            if (!ModelState.IsValid)
            {
                // Si la validación falla, devolver la página actual con errores de validación
                Message = "Por favor, corrige los errores en el formulario.";
                return Page();
            }

            // --- Tu lógica de autenticación va aquí ---
            // En una aplicación real, harías lo siguiente:
            // 1. Hash de la contraseña proporcionada.
            // 2. Consultar tu base de datos o servicio de autenticación para verificar el correo electrónico y la contraseña hasheada.
            // 3. Si las credenciales son válidas, iniciar sesión al usuario (ej. usando ASP.NET Core Identity).
            // 4. Redirigir a una página protegida.

            // Para propósitos de demostración:
            if (Email == "test@example.com" && Password == "password123")
            {
                Message = "¡Inicio de sesión exitoso!";
                // Normalmente redirigirías a otra página al iniciar sesión con éxito
                // return RedirectToPage("/Index"); // Ejemplo de redirección a la página de inicio
            }
            else
            {
                Message = "Correo electrónico o contraseña incorrectos.";
                // Opcional: Añadir un error de modelo para campos específicos si se desea
                // ModelState.AddModelError(string.Empty, "Intento de inicio de sesión inválido.");
            }

            // Devolver la página actual, que mostrará el mensaje
            return Page();
        }
    }
}
