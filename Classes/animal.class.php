<?php
    class Animal{
        private $nome;
        private $idade;

        //Métodos Nome
        public function setNome($nome){
            $this->nome = $nome;
        }
        public function getNome(){
            return $this->nome;
        }
        //

        //Métodos Idade
        public function setIdade($idade){
            $this->idade = $idade;
        }
        public function getIdade(){
            return $this->idade;
        }
        //
    }
?>