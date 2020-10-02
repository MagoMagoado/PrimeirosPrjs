<?php
    $numero = $_GET["txtNumero"];
    $tab = "";
    /*
    UTILIZANDO FOR
    for($cont = 0; $cont <= 10; $cont++){
        $tab .= $numero . " X " . $cont . " = " . ($numero * $cont) . "\n";
    }*/

    /*
    UTILIZANDO WHILE
    $cont = 0;
    while($cont <= 10){
        $tab .= $numero . " X " . $cont . " = " . ($numero * $cont) . "\n";
        $cont++;
    }*/

    /*UTILIZANDO O DO WHILE */
    $cont = 0;
    do{
        $tab .= $numero . " X " . $cont . " = " . ($numero * $cont) . "\n";
        $cont++;
    } while($cont <= 10);   
?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>
        Tabuada
    </title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-12">
                <h1 class="text-primary">
                    Tabuada
                </h1>
            </div>
        </div>
        <div class="row">
            <div class="col-12">
                <form action="tabuada.php" method="get">
                    <div class="form-group">
                        <label for="tNumero">
                            Número:
                        </label>   
                        <input type="number" name="txtNumero" id="tNumero"
                               value = "<?php echo $numero; ?>"
                               readonly class="form-control">              
                    </div>
                    <div class="form-group">
                        <label for="tTabuada">
                            Tabuada:
                        </label>
                        <textarea name="txtTabuada" id="tTabuada" cols="30" rows="15"
                                  class="form-control" readonly>
<?php echo $tab?>
                        </textarea>
                    </div>
                </form>
            </div>
        </div>
    </div>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>    
</body>
</html>