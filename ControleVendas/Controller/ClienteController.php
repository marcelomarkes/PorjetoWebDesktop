<?php

require_once '../DAO/ClienteDAO.php';
require_once '../Models/ClienteModel.php';

class ClienteController {
    
    public function InserirCliente(ClienteModel $vo) {
        
        if($vo->getEmail() == '' || $vo->getEndereco() == '' || $vo->getNomecliente() == '' || $vo->getTelefone() == '') {
            return 0;
        }
        
        $vo->setCodVendedor(1);
        $dao = new ClienteDAO();
        
        return $dao->InserirCliente($vo);
    }
    public function AlterarCliente(ClienteVO $vo) {
        
        if($vo->getEmail() == '' || $vo->getEndereco() == '' || $vo->getNomecliente() == '' || $vo->getTelefone() == '') {
            return 0;
        }
        
       
        $dao = new ClienteDAO();
        
        return $dao->AlterarCliente($vo);
    }
    public function ConsultarCliente () {
        $dao = new ClienteDAO();
        return $dao->ConsultarCliente(1);
    }
    public function  FiltrarCliente($cod_cliente) {
        $dao = new ClienteDAO();
        
        return $dao->FiltrarCliente($cod_cliente, 1);
    }
}
