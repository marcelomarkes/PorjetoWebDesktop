<?php

class FiltroModel {

    private $CodLogado;
    private $CodModelo;
    private $DtInicial;
    private $DtFinal;
    
    private function setCodLogado($p) {
        $this->CodLogado = $p;
    }
    private function getCodLogado() {
        return $this->CodLogado;
    }
    private function setCodModelo($p) {
        $this->CodModelo = $p;
    }
    private function getCodModelo() {
        return $this->CodModelo;
    }
    private function setDtInicial($p) {
        $this->DtInicial = $this->DataParaBanco($p);
    }
    private function getDtInicial() {
        return $this->DtInicial;      
    }
    private function setDtFinal($p) {
        $this->DtFinal = $this->DataParaBanco($p);
    }
    private function getDtFinal() {
        return $this->DtFinal;
    }
    private function DataParaBanco($p) {
        $this->explode('/', $p)[2] . '-' . explode('/', $p)[1] . '-' . explode('/', $p)[0];
    }
}
