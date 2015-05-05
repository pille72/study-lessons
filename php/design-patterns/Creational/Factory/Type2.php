<?php
namespace DesignPatterns\Creational\Factory;

/**
 * Type2 class
 */
class Type2 extends BasicType {
  /**
   * construct function
   * @override
   * @param array $name
   */
  public function __construct($name) {
    parent::__construct(implode(', ', $name));
  }
}
