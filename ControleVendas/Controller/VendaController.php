<?php
require_once '../DAO/VendasDAO.php';
require_once '../Models/VendedorModel.php';

class VendasController {
    
    public function FinalizarVendas(VendasModel $vo) {
        if($vo->getCodCliente() == '' || $vo->getDescricao() == '' || $vo->getFormaPgto() == ''){
            return 0;
        }
        $vo->setCodVendedor(1);
        $vo->setdataVenda(date('d/m/y'));
        $dao = new VendasDAO();
        
        return $dao->FinalizarVendas($vo);
    }
     public function ConsultarModelos(){
         $cod_empresa = 1;
         $dao = new VendasDAO();
         return $dao->ConsultarModelos($cod_empresa);
     }
     public function FiltrarVeiculo($Cod_Modelo){
         $dao = new VendasDAO();
         return $dao->FiltrarVeiculo($Cod_Modelo);
         
     }
      public function DetalheVeiculo($cod_veiculo){
          $cod_empresa = 1;
          $dao = new VendasDAO();
          return $dao->DetalheVeiculo($cod_veiculo, $cod_empresa);
      }
      public function MinhasVendas(FiltroVO $vo){
          if($vo->getDtInicial() == '' || $vo->getDtFinal() == ''){
              return 0;
          }
          $vo->setDtInicial($vo->getDtInicial());
          $v0->setDtFinal($vo->getDtFinal());
          $vo->setCodigoLogado(1);
          
          $dao = new VendasDAO();
          
          return $dao->MinhasVendas($vo);
      }
            
}

?>