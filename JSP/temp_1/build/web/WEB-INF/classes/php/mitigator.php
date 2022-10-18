<?php

    class Mitigator{
        function __construct(){

        }
        function sanitize($string){
            // Mitigation of HTML or XSS runnable code
            $mitigatable_characters = array("/</", "/>/", "/ /", "/&/", "/'/", '/"/', "/¢/", "/£/", "/¥/", "/€/", "/©/", "/®/");
            $mitigated_characters = array("&lt;", "&gt;", "&nbsp;", "&amp;", "&apos;", "&quot;", "&cent;", "&pound;", "&yen;", "&euro;", "&copyright;", "&reg;");
            $string = preg_replace($mitigatable_characters, $mitigated_characters, $string);
            return $string;
        }
    }

?>
