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
        $produto=$_GET['produto'];
        $valor=$_GET['valor'];
        $quant=$_GET['quant'];
        ?>
    </head>
    <div class="container-fluid-width pb-3 pt-5">
        <h1 class="centro mt-3">Sistema de Venda</h1>
        <hr style="background-color: red;" class="linha-horizontal rounded-circle mb-4"/>

        <div class="container w-100 border border-dark bg-light mt-5 mb-5">
            <form method="GET" action="dados_alunos.php" class="mt-2 mb-3">
                <div class="form-group">
                  <label for="nome">Funcionário</label>
                  <input type="text" class="form-control" id="nome" <?php echo "value='$nome'";?> disabled>
                </div>
                <div class="form-group">
                    <div class="row">
                        <div class="col-6">
                            <label for="produto">Produto:</label>
                            <input type="text" class="form-control" id="produto" <?php echo "value='$produto'";?> disabled>
                        </div>
                        <div class="col-3">
                            <label for="valor">Valor:</label>
                            <input type="text" class="form-control" id="valor" <?php echo "value='$valor'";?> disabled>
                        </div>
                        <div class="col-3">
                            <label for="quant">Quantidade:</label>
                            <input type="text" class="form-control" id="quant" <?php echo "value='$quant'";?> disabled>
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