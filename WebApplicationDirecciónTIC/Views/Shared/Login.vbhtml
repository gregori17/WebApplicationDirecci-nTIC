﻿
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Login</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <div>

        <main role="main" class="container my-auto">
            <div class="row">
                <div id="login" class="col-lg-4 offset-lg-4 col-md-6 offset-md-3
                    col-12">
                    <h2 class="text-center">Bienvenido de nuevo</h2>
                    <img class="img-fluid mx-auto d-block rounded"
                         src="https://picsum.photos/id/870/300/200" />

                    <form>
                        <div class="form-group">
                            <label for="correo">Correo</label>
                            <input id="correo" name="correo"
                                   class="form-control" type="email"
                                   placeholder="Correo electrónico">
                        </div>
                        <div class="form-group">
                            <label for="palabraSecreta">Contraseña</label>
                            <input id="palabraSecreta" name="palabraSecreta"
                                   class="form-control" type="password"
                                   placeholder="Contraseña">
                        </div>
                        <button type="submit" class="btn btn-primary mb-2">
                            Entrar
                        </button>
                        <br>
                        <a href="#">Contraseña olvidada</a>
                    </form>
                </div>
            </div>
        </main>
    </div>
</body>
</html>
