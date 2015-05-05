<?php
include_once('Autoloader.php');

echo "\nDesign Patterns Test \n--------------------\n \n";

// Test creational patterns
echo "Creational Patterns Start: \n--------------------\n\n";

include_once('SingletonTest.php');
include_once('FactoryTest.php');
include_once('PrototypeTest.php');

echo "\n\nCreational Patterns End \n--------------------\n\n";


// Test behavioral patterns
echo "Behavioral Patterns Start: \n--------------------\n\n";

include_once('MementoTest.php');

echo "\n\nBehavioral Patterns End \n--------------------\n\n";
