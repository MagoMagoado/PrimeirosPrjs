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
        $horas=$_GET['horas'];
        $valor=$_GET['valor'];
        $grat=$_GET['grat'];
        ?>
    </head>
    <div class="container-fluid-width pb-3 pt-5">
        <h1 class="centro mt-3">Holerite</h1>
        <hr style="background-color: red;" class="linha-horizontal rounded-circle mb-4"/>

        <div class="container w-100 border border-dark bg-light mt-5 mb-5">
            <form method="GET" action="dados_holerite.php" class="mt-2 mb-3">
                <div class="form-group">
                  <label for="nome">Funcionário</label>
                  <input type="text" class="form-control" id="nome" <?php echo "value='$nome'";?> disabled>
                </div>
                <div class="form-group w-50">
                    <div class="row">
                        <div class="col">
                            <label for="horas">Hora Trabalhada:</label>
                            <input type="text" class="form-control" id="horas" <?php echo "value='$horas'";?> disabled>
                        </div>
                        <div class="col">
                            <label for="valor">Valor da Hora:</label>
                            <input type="text" class="form-control" id="valor" <?php echo "value='$valor'";?> disabled>
                        </div>
                        <div class="col">
                            <label for="grat">Gratificação:</label>
                            <input type="text" class="form-control" id="grat" <?php echo "value='$grat'";?> disabled>
                        </div>
                    </div>
                </div>
                <div class="d-flex justify-content-left">
                    <button type="submit" class="btn btn-primary mr-5">Enviar</button>
                    <button type="submit" class="btn btn-primary" disabled>Cancelar</button>
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