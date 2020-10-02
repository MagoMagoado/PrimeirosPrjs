<!DOCTYPE html>
<html lang="pt/br">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" type="text/css" href="css/estilo.css">
        <link rel= "stylesheet" href= "css_bootstrap/bootstrap.css" >
		<link rel= "stylesheet" href= "css_bootstrap/bootstrap.min.css" >
        <title>XVidros|Vidros</title>

        <?php
        $nome=$_GET['nome'];
        $nota1=$_GET['nota1'];
        $nota2=$_GET['nota2'];
        $media=($nota1+$nota2)/2;
        ?>
    </head>
    <div class="container-fluid-width pb-3 pt-5">
        <h1 class="centro mt-3">Ficha do Aluno</h1>
        <hr style="background-color: red;" class="linha-horizontal rounded-circle mb-4"/>

        <div class="container w-50 border border-dark bg-light mt-5 mb-5">
        <form class="mt-2 mb-3">
                <div class="form-group">
                  <label for="nome">Aluno</label>
                  <input type="text" class="form-control" id="nome" <?php echo "value='$nome'";?> disabled>
                </div>
                <div class="form-group">
                    <div class="row">
                        <div class="col">
                            <label for="horas">Nota 1°:</label>
                            <input type="text" class="form-control" id="horas" <?php echo "value='$nota1'";?> disabled>
                        </div>
                        <div class="col">
                            <label for="valor">Nota 2°:</label>
                            <input type="text" class="form-control" id="valor" <?php echo "value='$nota2'";?> disabled>
                        </div>
                    </div>
                </div>
                <div class="d-flex justify-content-center">
                    <div class="form-group">
                        <label for="media">Média:</label>
                        <input type="text" class="form-control" id="media" aria-describedby="emailHelp" <?php echo "value='$media'";?> disabled>
                        <small id="emailHelp" class="form-text text-muted">Procure sempre aprimorar.</small>
                    </div>
                </div>
                <div class="d-flex justify-content-center">
                    <button class="btn mr-5"><a href="aluno.php">OK</a></button>
                </div>
            </form>
        </div>

    </div>
    <div id="footer">
        <ul>
            <li>Rua Francisco Valzacchi, 51</li>
            <li>Vila Rosa</li>
            <li>Taquaritinga - SP</li>
        </ul>
    </div>
    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/bootstrap/bootstrap.bundle.js"></script>
    <script src="js/bootstrap/bootstrap.bundle.min.js"></script>
</html>