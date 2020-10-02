<!DOCTYPE html>
<html lang="pt/br">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" type="text/css" href="css/estilo.css">
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
        <title>Cálculo da Média</title>

<?php
$nome = $_POST["nome"];
$senha=$_POST["senha"];
?>

    </head>
    <div class="container-fluid-width pb-3">
        <header>
            <nav class="navbar navbar-expand-lg navbar-dark" style="background-color: #0d9213bb">
                <a class="navbar-brand" href="#"><img id="logo" src="img/logo.png"></a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            </nav>
        </header>
        <h1 class="centro mt-3">Login</h1>
        <hr style="background-color: red;" class="linha-horizontal rounded-circle mb-4"/>
<body>
    <div class="container w-50 border border-dark bg-light mt-5 mb-5">
        <div class="row">
            <div class="col-12">
                <h1 class="text-primary">
                    Login
                </h1>
            </div>
        </div>
        <div class="row">
            <div class="col-12 pb-3">
                <form action="conferirLogin.php" method="post">
                    <div class="form-group">
                        <label for="tNome"> Usuário:</label>
                        <input type="text" class="form-control" value="<?php echo $nome; ?>"  disabled>
                    </div>
                    <div class="form-group">
                        <label for="senha"> Senha:</label>
                        <input type="password" class="form-control" value="<?php echo $senha; ?>" disabled>
                    </div>
                    <div class="form-group">
                        <label for="senha"> Status:</label>
                        <input class="form-control " value="INFORMAÇÕES ACEITAS" disabled>
                    </div>
                    <bnt class="btn btn-primary"><a href="login.html" style="color:white">Voltar</a></bnt>
                </form>         
            </div>
        </div>
    </div>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
</body>
</html>