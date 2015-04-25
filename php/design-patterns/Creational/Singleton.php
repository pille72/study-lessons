<?php
namespace DesignPatterns\Creational;

class Singleton {

	/**
	 * this is our instance
	 * @var array
	 */
	protected static $instances;
	/**
	 * make it private, so one can't create an object with `new`
	 * @return void
	 */
	private function __construct() {

	}

	/**
	 * some function to say something
	 */
	public function saySomething() {
		return 'Hello I\'m an singleton instance from a class called "Singleton"';
	}

	/**
	 * disallow cloning objects
	 * @return void
	 */
	private function __clone() { }

	/**
	 * return the singleton object instance
	 *
	 * make sure that extended classes will return the correct instance
	 */
	public function getInstance() {
		// if not set, create an instance
		$cls = get_called_class(); // late-static-bound class name
		if (!isset(self::$instances[$cls])) {
			self::$instances[$cls] = new static;
		}

		return self::$instances[$cls];
	}
}
