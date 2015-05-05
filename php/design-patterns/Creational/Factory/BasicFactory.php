<?php
namespace DesignPatterns\Creational\Factory;

/**
 * a basic factory class
 */
class BasicFactory {
  /**
   * creates a new Instance based on type
   * @param string $type
   */
  public function createNewInstance($type = 'Type1', $name) {
    switch($type) {
      case 'Type1':
        $instance = new \DesignPatterns\Creational\Factory\Type1($name);
        break;
      case 'Type2':
        $instance = new \DesignPatterns\Creational\Factory\Type2($name);
        break;
      case 'Type3':
        $instance = new \DesignPatterns\Creational\Factory\Type3($name);
        break;
      default:
        $instance = new \DesignPatterns\Creational\Factory\BasicType($name);
    }

    return $instance;
  }
}
