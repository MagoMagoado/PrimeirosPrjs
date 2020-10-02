<?php
    include_once "animal.class.php";

    class Peixe extends Animal{
        private $escamacao;

        //Método escamação
        public function setEscamacao($escamacao){
            $this->escamacao = $escamacao;
        }

        public function getEscamacao(){
            return $this->escamacao;
        }
    }
?>