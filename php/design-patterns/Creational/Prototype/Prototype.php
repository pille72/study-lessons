<?php
namespace DesignPatterns\Creational\Prototype;

abstract class Prototype {
  protected $title;
  protected $color;

  abstract function __clone();

  /**
   * @return string $title
   */
  function getTitle() {
    return $this->title;
  }

  /**
   * set title
   * @param string $title
   */
  function setTitle($title) {
    $this->title = $title;
  }

  /**
   * @return string $color
   */
  function getColor() {
    return $this->color;
  }
}
