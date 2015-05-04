<?php
namespace DesignPatterns\Behavioral;

/**
 * Memento class
 */
class Memento {
	/**
	 * our memento state
	 * @var string
	 */
	private $state;

	/**
	 * constructor with state
	 * @param string $state the state which represents the Memento
	 * @return void
	 */
	public function __construct($state) {
		$this->state = $state;
	}

	/**
	 * return the state
	 * @return string $state
	 */
	public function getState() {
		return $this->state;
	}
}