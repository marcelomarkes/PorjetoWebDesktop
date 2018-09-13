<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <?php
        include '_head.php';
        ?>
    </head>
    <body>
        <div id="wrapper">
            <?php
            include '_topo.php';
            include '_menu.php';
            ?>
            <div id="page-wrapper" >
                <div id="page-inner">
                    <div class="row">
                        <div class="col-md-12">
                            <h2>Minhas vendas</h2>
                        </div>
                    </div>

                    <hr />
                    
                    <div class="col-md-6">
                        <div class="form-group" >
                            <label>Data Inicial</label>
                            <input class="form-control"  id="dtinicial"/>
                            <label id="val_dtinicial" class="validar"></label>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group" >
                            <label>Data Final</label>
                            <input class="form-control"  id="dtfinal"/>
                            <label id="val_dtfinal" class="validar"></label>
                        </div>
                    </div>
                   
                    <center><button type="submit" class="btn btn-info" onclick="return Validar(5)">Pesquisar</button></center>
                   
                    <hr />

                    <div class="row">
                        <div class="col-md-12">
                            <!-- Advanced Tables -->
                            <div class="panel panel-default">
                                <div class="panel-heading">
                                   Resultado
                                </div>
                                <div class="panel-body">
                                    <div class="table-responsive">
                                        <table class="table table-striped table-bordered table-hover" id="dataTables-example">
                                            <thead>
                                                <tr>
                                                     <th>Data</th>
                                                    <th>Marca</th>
                                                    <th>Modelo</th>
                                                    <th>Cliente</th>
                                                    <th>Valor</th>
                                                   
                                                   
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr class="odd gradeX">
                                                    <td></td>
                                                    <td></td>
                                                    <td></td>
                                                    <td></td>
                                                    <td></td>
                                                  
                                                </tr>

                                            </tbody>
                                        </table>
                                    </div>

                                </div>
                            </div>
                            <!--End Advanced Tables -->
                        </div>
                    </div>
                </div>

            </div>

        </div>



    </body>
</html>