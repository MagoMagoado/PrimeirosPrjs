<?php
    include_once "cachorro.class.php";
    include_once "peixe.class.php";

    $doguinho = new Cachorro();
    //Método Setter
    $doguinho->setNome(" Doguinho");
    $doguinho->setIdade(" 3");
    $doguinho->setPelagem(" Lisa");

    $peixinho = new Peixe();
    $peixinho->setNome(" Dourado");
    $peixinho->setIdade(" 3 meses");
    $peixinho->setEscamacao(" Viscosa");

    //Método Getter
    echo "CACHORRO <br/>";
    echo "Nome:".$doguinho->getNome()."<br/>";
    echo "Idade:".$doguinho->getIdade()."<br/>";
    echo "Pelagem:".$doguinho->getPelagem()."<br/>";
    
    echo "---------------------------------- </br>";

    echo "PEIXE <br/>";
    echo "Nome:".$peixinho->getNome()."</br>";
    echo "Idade:".$peixinho->getIdade()."</br>";
    echo"Escamação:".$peixinho->getEscamacao()."</br>";
?>