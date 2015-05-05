<?php
namespace DesignPatterns\Creational\Prototype;

class RedBookPrototype extends Prototype {
  /**
   * construct function
   */
  public function __construct() {
    $this->color = 'red';
  }

  /**
   * clone function
   */
  public function __clone() { }
}
