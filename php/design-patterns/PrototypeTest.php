<?php
include_once('Autoloader.php');

error_reporting(0);

/**
 * Prototype-Test
 */

echo "Start Test: - Prototype - \n\n";

$blueBook = new \DesignPatterns\Creational\Prototype\BlueBookPrototype();
$redBook = new \DesignPatterns\Creational\Prototype\RedBookPrototype();

$blueBookClone = clone $blueBook;
$blueBookClone->setTitle('The Bible');
echo 'BlueBook-Clone 1: >' . $blueBookClone->getColor() . '< ' . $blueBookClone->getTitle();
echo "\n";

$redBookClone = clone $redBook;
$redBookClone->setTitle('The Lord Of the Rings');
echo 'RedBook-Clone 1: >' . $redBookClone->getColor() . '< ' . $redBookClone->getTitle();
echo "\n";

$redBookClone2 = clone $redBook;
$redBookClone2->setTitle('The Lord Of the Rings - The Return Of The King');
echo 'RedBook-Clone 2: >' . $redBookClone2->getColor() . '< ' . $redBookClone2->getTitle();
echo "\n";

$blueBookClone2 = clone $blueBook;
$blueBookClone2->setTitle('The Bible - Some Other Translation');
echo 'BlueBook-Clone 1: >' . $blueBookClone2->getColor() . '< ' . $blueBookClone2->getTitle();
echo "\n";

echo "\nEnd Test: - Prototype -\n";

/**
 * Prototype-Test
 */
