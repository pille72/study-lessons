<?php
namespace DesignPatterns\Creational\Prototype;

class BlueBookPrototype extends Prototype {
  /**
   * construct function
   */
  public function __construct() {
    $this->color = 'blue';
  }

  /**
   * clone function
   */
  public function __clone() { }
}
