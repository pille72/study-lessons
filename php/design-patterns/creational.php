<?php
echo "Creational Patterns Start: \n--------------------\n\n";

/**
 * Singleton-Test
 */

echo "Start Test: - Singleton - \n\n";

$singletonInstance = \DesignPatterns\Creational\Singleton::getInstance();
echo 'Instance 1: ' . $singletonInstance->saySomething();
echo "\n";

$secondSingletonInstance = \DesignPatterns\Creational\Singleton::getInstance();

echo 'Instance 2: ' . $secondSingletonInstance->saySomething();
echo "\n";

$someOtherSingelton = \DesignPatterns\Creational\SomeOtherSingleton::getInstance();

echo 'Instance 3: ' . $someOtherSingelton->saySomething();
echo "\n";

echo "\nEnd Test: - Singleton -";

/**
 * Singleton-Test
 */

echo "\n\nCreational Patterns End \n--------------------\n\n";