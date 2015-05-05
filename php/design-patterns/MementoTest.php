<?php
include_once('Autoloader.php');

/**
 * Memento-Test
 */

echo "Start Test: - Memento - \n\n";

$originator = new \DesignPatterns\Behavioral\Memento\Originator();
$originator->setState('First-State');
echo 'Originator State: ' . $originator->getState();
echo "\n";

$memento = $originator->saveToMemento();
$originator->setState('Second-State');

echo 'Originator State: ' . $originator->getState();
echo "\n";

$originator->restoreFromMemento($memento);
echo 'Originator Rollback to State: ' . $originator->getState();
echo "\n";

echo 'Originator State: ' . $originator->getState() . ' = Memento State: ' . $memento->getState();
echo "\n";

$originator->setState('Second-State');
$memento = $originator->saveToMemento();
$originator->setState('Third-State');

echo 'Originator Third State: ' . $originator->getState();
echo "\n";

echo 'Memento saved State: ' . $memento->getState() . ' and so Originator could rollback to this...';

echo "\n\nEnd Test: - Memento - \n";

/**
 * Memento-Test
 */
