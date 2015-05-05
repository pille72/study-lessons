<?php
namespace DesignPatterns\Behavioral\Memento;

/**
 * Originator class
 */
class Originator {
	/**
	 * our state
	 * @var string
	 */
	private $state;

	/**
	 * return the state
	 * @return string $state
	 */
	public function getState() {
		return $this->state;
	}


	/**
	 * set the state
	 * @param string $state
	 * @return void
	 */
	public function setState($state) {
		$this->state = $state;
	}

	/**
	 * gets an memento with the current state
	 * @return \DesignPatterns\Behavioral\Memento $memento
	 */
	public function saveToMemento() {
		return new Memento($this->state);
	}

	/**
	 * restores the state to a given memento
	 * @param \DesignPatterns\Behavioral\Memento $memento
	 * @return void
	 */
	public function restoreFromMemento($memento) {
		if(get_class($memento) === 'DesignPatterns\Behavioral\Memento\Memento') {
			$this->state = $memento->getState();
		} else {
			throw new \Exception('This was no Memento!');
		}
	}
}
