<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <?php
        include '_head.php'   
    ?>
        
</head>
<body>
    <div class="container">
        <div class="row text-center ">
            <div class="col-md-12">
                <br /><br />
                <h2> Controle de Vendas : Vendedor</h2>
               
              
                 <br />
            </div>
        </div>
         <div class="row ">
               
                  <div class="col-md-4 col-md-offset-4 col-sm-6 col-sm-offset-3 col-xs-10 col-xs-offset-1">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                        <strong>   Entre com seus dados </strong>  
                            </div>
                            <div class="panel-body">
                                <form role="form">
                                       <br />
                                     <div class="form-group input-group">
                                            <span class="input-group-addon"><i class="fa fa-tag"  ></i></span>
                                            <input type="text" class="form-control" placeholder="Insira o Usuário" id="usuario" />
                                        </div>
                                       <div class="form-group">
                                           <label id="val_email" class="validar"></label>
                                       </div>
                                        <div class="form-group input-group">
                                            <span class="input-group-addon"><i class="fa fa-lock"  ></i></span>
                                            <input type="password" class="form-control"  placeholder="Insira a Senha" id="senha"/>
                                        </div>
                                       <div class="form-group">
                                           <label id="val_senha" class="validar">* Preencher o campo senha!</label>
                                       </div>
                                       <button class="btn btn-primary" onclick="return Validar(1)">Acessar</button>
                                    <hr />
                                   
                                    </form>
                            </div>
                           
                        </div>
                    </div>
                
                
        </div>
    </div>
   
</body>
</html>
