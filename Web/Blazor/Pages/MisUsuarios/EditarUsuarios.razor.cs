using Blazor.Interfaces;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace Blazor.Pages.MisUsuarios
{
    public partial class EditarUsuarios
    {
        [Inject] private IUsuariosServicios usuariosServicios { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }

        private Usuario user = new Usuario();
        [Parameter] public string CodigoUsuario { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if (!string.IsNullOrEmpty(CodigoUsuario))
            {
                user = await usuariosServicios.GetPorCodigoAsync(CodigoUsuario);
            }
        }


    }
}
