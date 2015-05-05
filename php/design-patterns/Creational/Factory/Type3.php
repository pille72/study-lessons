<?php
namespace DesignPatterns\Creational\Factory;

/**
 * Type3 class
 */
class Type3 extends BasicType {
  /**
   * construct function
   * @override
   * @param string $name
   */
  public function __construct($name) {
    parent::__construct(ucwords($name));
  }
}
