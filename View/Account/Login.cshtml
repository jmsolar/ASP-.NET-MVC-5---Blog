@model Futbolizando_Fútbol_Blog.Models.LoginViewModel
@{
    ViewBag.Title = "Iniciar sesión";
    Layout = "~/Views/Shared/_ClearLayout.cshtml";
}

<div class="nav-jumbotron modal-login">
    <div id="formLogin">
        @Html.AntiForgeryToken()
        <form class="login form-horizontal" role="form">
            <div class="modal fade margin-top-32" id="login" role="dialog" data-backdrop="static">
                <div class="modal-dialog">
                    <div class="modal-content modal-content-login">
                        <div class="modal-header no-border padding-bottom-0">
                            <a href="@Url.Action("Index", "Home")" class="close">
                                <span aria-hidden="true">&times;</span>
                            </a>
                            <h4 class="modal-title"><b>Login de Administrador</b></h4>
                        </div>
                        <div class="modal-body" id="frmLogin">
                            <div class="form-group">
                                @Html.ValidationSummary(true, "", new { @class = "text-danger pb-8" })
                                <div class="col-md-10 col-xs-10 col-md-offset-1 col-xs-offset-1">
                                    @Html.TextBoxFor(m => m.Username, new { @class = "field width-100 display-block black-color pt-8 pb-8 ps-8 border-radius-2 input-transition border-left-width-focus-50 dark-red-color-border-focus dark-red-box-shadow border-solid-input-1", placeholder = "Usuario", required = "required", autofocus = "autofocus", id = "Username" })
                                    <span class="glyphicon glyphicon-user glyphicon-user-login white-color position-absolute glyphicon-transition"></span>
                                </div>
                                <div class="col-md-10 col-xs-10 col-md-offset-1 col-xs-offset-1">
                                    @Html.ValidationMessageFor(m => m.Username, "", new { @class = "text-danger pt-16 pb-16" })
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-10 col-xs-10 col-md-offset-1 col-xs-offset-1">
                                    @Html.TextBoxFor(m => m.Email, new { @class = "field width-100 display-block black-color pt-8 pb-8 ps-8 border-radius-2 input-transition border-left-width-focus-50 dark-red-color-border-focus dark-red-box-shadow border-solid-input-1", placeholder = "Correo electrónico", required = "required", id = "Email" })
                                    <span class="glyphicon glyphicon-envelope glyphicon-envelope-login white-color position-absolute glyphicon-transition"></span>
                                </div>
                                <div class="col-md-10 col-xs-10 col-md-offset-1 col-xs-offset-1">
                                    @Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger pt-16 pb-16" })
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-10 col-xs-10 col-md-offset-1 col-xs-offset-1">
                                    @Html.PasswordFor(m => m.Password, new { @id = "passInput", @class = "field width-100 display-block black-color pt-8 pb-8 ps-8 border-radius-2 input-transition border-left-width-focus-50 dark-red-color-border-focus dark-red-box-shadow border-solid-input-1", placeholder = "Contraseña", required = "required" })
                                    <span class="glyphicon glyphicon-eye-close glyphicon-eye-close-login white-color position-absolute glyphicon-transition"></span>
                                </div>
                                <div class="col-md-10 col-xs-10 col-md-offset-1 col-xs-offset-1">
                                    @Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger pt-16 pb-16" })
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-10 col-xs-10 col-md-offset-1 col-xs-offset-1">
                                    @Html.PasswordFor(m => m.RepeatPassword, new { @id = "repeatpassInput", @class = "field width-100 display-block black-color pt-8 pb-8 ps-8 border-radius-2 input-transition border-left-width-focus-50 dark-red-color-border-focus dark-red-box-shadow border-solid-input-1", placeholder = "Repetir contraseña", required = "required" })
                                    <span class="glyphicon glyphicon-eye-close glyphicon-eye-close-login white-color position-absolute glyphicon-transition"></span>
                                </div>
                                <div class="col-md-10 col-xs-10 col-md-offset-1 col-xs-offset-1">
                                    @Html.ValidationMessageFor(m => m.RepeatPassword, "", new { @class = "text-danger pt-16 pb-16" })
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-10 col-xs-10 col-md-offset-1 col-xs-offset-1">
                                    <text id="errors" class="text-danger pt-16 pb-16"></text>
                                </div>
                            </div>
                            <div id="forgotPassword" class="form-group text-align-right">
                                <div class="col-md-10 col-xs-10 col-md-offset-1 col-xs-offset-1">
                                    @Html.ActionLink("¿Olvidaste la contraseña?", "ForgotPassword", null, new { @class = "no-text-decoration dark-red-color forgot-Pass" })
                                </div>
                            </div>

                        </div>
                        <div class="modal-footer no-border padding-0">
                            <button tabindex="4">
                                <i class="spinner"></i>
                                <span class="stateLogin">Iniciar sesión</span>
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </div>
</div>

@section Login {

    <script type="text/javascript">
        // Show modal login
        $("#login").modal('show');

        var accountDto = {};
        var workingLogin = false;

        // Load record Note
        function loadAccount() {
            accountDto.userName = $('#Username').val();
            accountDto.Email = $('#Email').val();
            accountDto.Password = $('#passInput').val();
            accountDto.RepeatPassword = $('#repeatpassInput').val();
            var textErrors = document.getElementById("errors");
            textErrors.innerText = "";
        }

        // Reset form login
        function resetFormLogin() {
            $('.login').each(function () {
                this.reset();
            });
        }

        $('.login').on("submit", function (e) {
            e.preventDefault();
            if (workingLogin) return;
            workingLogin = true;
            loadAccount();
            if (accountDto.userName !== "" && accountDto.Email !== "" && accountDto.Password !== "" && accountDto.RepeatPassword !== "") {
                var buttonLogin = this;
                var stateLogin = document.getElementsByClassName("stateLogin")[0];
                $(buttonLogin).addClass('loadingLogin');
                $(stateLogin).html('Verificando datos');
                $.ajax({
                    url: "/api/accounts",
                    method: "POST",
                    data: JSON.stringify(accountDto),
                    contentType: "application/json; charset=utf-8",
                    success: function (resultEmail) {
                        $(buttonLogin).addClass('okLogin');
                        $(stateLogin).html('Bienvenido!');
                        setTimeout(
                            function () {
                                $(stateLogin).html('Cargando perfil');
                                workingLogin = false;
                                resetFormLogin();
                                setTimeout(
                                    function () {
                                        $("#login").modal('hide');
                                        $(buttonLogin).removeClass('okLogin');
                                        $(buttonLogin).removeClass('loadingLogin');
                                        $(stateLogin).html('Iniciar sesión');
                                        window.location.href = '@Url.Action("Index", "Manage")';
                                    }, 2000);
                            }, 3000);
                    },
                    error: function (resultEmail) {
                        setTimeout(function () {
                            workingLogin = false;
                            $(stateLogin).html('Ocurrio un error');
                            var errorText = resultEmail.responseText.slice(1, resultEmail.responseText.length - 1);
                            if (errorText === "Lockout") {
                                window.location.href = '@Url.Action("Lockout", "Account")';
                            }
                            else {
                                setTimeout(function () {
                                    $(buttonLogin).removeClass('loadingLogin');
                                    $(stateLogin).html('Iniciar sesión');
                                    var textErrors = document.getElementById("errors");
                                    textErrors.innerText = errorText;
                                }, 3000);
                            }
                        }, 3000);
                    }
                });
            }
        });
    </script>

}