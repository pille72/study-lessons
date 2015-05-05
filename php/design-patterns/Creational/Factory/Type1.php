<?php
namespace DesignPatterns\Creational\Factory;

/**
 * Type1 class
 */
class Type1 extends BasicType {
  /**
   * construct function
   * @override
   * @param string $name
   */
  public function __construct($name) {
    parent::__construct(ucfirst($name));
  }
}
