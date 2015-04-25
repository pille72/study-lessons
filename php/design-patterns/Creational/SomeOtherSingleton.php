<?php
namespace DesignPatterns\Creational;

class SomeOtherSingleton extends Singleton {
	/**
	 * some function to say something
	 */
	public function saySomething() {
		return 'Hello I\'m an singleton instance from a subclass called "SomeOtherSingleton"';
	}
}
