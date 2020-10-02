<?php
    include_once "animal.class.php";

    class Cachorro extends Animal{
        private $pelagem;

        //Método Pelagem
        public function setPelagem($pelagem){
            $this->pelagem = $pelagem;
        }

        public function getPelagem(){
            return $this->pelagem;
        }
        //
    }
?>