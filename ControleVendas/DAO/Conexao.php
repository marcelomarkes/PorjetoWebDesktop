<?php


// Configurações do site
define('HOST', 'localhost'); //IP
define('USER', 'root'); //usuario
define('PASS', null); //Senha
define('DB', 'db_vendas'); //Banco

class Conexao {

    /** @var PDO */
    private static $Connect;

    private static function Conectar() {
        try {

            //Verifica se a conexão não existe
            if (self::$Connect == null):

                $dsn = 'mysql:host=' . HOST . ';dbname=' . DB . ';charset=utf8';
                self::$Connect = new PDO($dsn, USER, PASS, null);
            endif;
        } catch (PDOException $e) {
            echo $e->getMessage();
        }
       
        //Seta os atributos para que seja retornado as excessões do banco
        self::$Connect->setAttribute(PDO::ATTR_ERRMODE,PDO::ERRMODE_EXCEPTION);
       
        return self::$Connect;
    }

    public function getConexao() {
        return self::Conectar();
    }
    
    
}