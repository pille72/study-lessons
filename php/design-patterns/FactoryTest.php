<?php
include_once('Autoloader.php');

/**
* Factory-Test
*/

echo "Start Test: - Factory - \n\n";

$factory = new \DesignPatterns\Creational\Factory\BasicFactory();

// create first type class
$first = $factory->createNewInstance('Type1', 'mylowercase');

echo 'Instance 1: Type1: ' . $first->getName();
echo "\n";

// create second type class
$second = $factory->createNewInstance('Type2', array('my', 'fucking', 'words'));

echo 'Instance 2: Type2: ' . $second->getName();
echo "\n";

// create second type class
$third = $factory->createNewInstance('Type3', 'my words are all lowercase');

echo 'Instance 2: Type3: ' . $third->getName();
echo "\n";

// create default type class
$default = $factory->createNewInstance('Type4', 'Come as you are, as you were ...');

echo 'Instance 2: Default: ' . $default->getName();
echo "\n";

echo "\nEnd Test: - Factory -\n";

/**
* Factory-Test
*/
