<?php
namespace DesignPatterns\Creational\Factory;

/**
 * a basic BasicType class
 */
class BasicType {
  /**
   * @var string
   */
  private $name;

  /**
   * construct function
   * @param string $name
   */
  public function __construct($name) {
    $this->name = $name;
  }

  /**
   * get name
   * @param string $name
   */
  public function getName() {
    return $this->name;
  }
}
