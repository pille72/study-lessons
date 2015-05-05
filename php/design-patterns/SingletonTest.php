<?php
include_once('Autoloader.php');

/**
 * Singleton-Test
 */

echo "Start Test: - Singleton - \n\n";

$singletonInstance = \DesignPatterns\Creational\Singleton\Singleton::getInstance();
echo 'Instance 1: ' . $singletonInstance->saySomething();
echo "\n";

$secondSingletonInstance = \DesignPatterns\Creational\Singleton\Singleton::getInstance();

echo 'Instance 2: ' . $secondSingletonInstance->saySomething();
echo "\n";

$someOtherSingelton = \DesignPatterns\Creational\Singleton\SomeOtherSingleton::getInstance();

echo 'Instance 3: ' . $someOtherSingelton->saySomething();
echo "\n";

echo "\nEnd Test: - Singleton -\n";

/**
 * Singleton-Test
 */
