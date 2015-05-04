<?php
include_once('Autoloader.php');

$autoLoader = new AutoLoader('DesignPatterns');
$autoLoader->register();

echo "\nDesign Patterns Test \n--------------------\n \n";

// Test creational patterns
include_once('creational.php');

// Test behavioral patterns
include_once('behavioral.php');