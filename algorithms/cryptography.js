var MyCrypto = (function() {
	var _ecb_encrypt, _ecb_decrypt, _encrypt_block,
	_get_decrypt_key;

	_get_decrypt_key = function(key) {
		var decryptKey = [];
		for(var i=0; i<key.length;i++) {
			decryptKey[key[i]-1] = i+1;
		}

		return decryptKey;
	};

	_encrypt_block = function(block, length, key) {
		var i, eBlock = [];

		for(i=0;i<length;i++) {
			eBlock[i] = block.substr(key[i]-1, 1);
		}

		console.log('Encrypt: ' + block + ' -> ' + eBlock.join('') + '\n');

		return eBlock.join('');
	};

	_ecb_encrypt = function(plaintext, length, key) {
		var i, ii, tmpBlock, blocks = [],
		plCopy = plaintext,
		blocksLength = Math.ceil(plaintext.length / length);

		if(plaintext.length % length !== 0) {
			console.log( 'Ay you need ' + ((blocksLength * length) - plaintext.length) + ' more chars');
			return false;
		}

		for(i=0; i<blocksLength; i++) {
			tmpBlock = plaintext.substr(i*4, length);
			blocks[i] = _encrypt_block(tmpBlock, length, key);
		}

		return blocks.join('');
	};

	_ecb_decrypt = function(encryptedText, length, key) {
		key = _get_decrypt_key(key);
		return _ecb_encrypt(encryptedText, length, key);
	};

	var test = function() {
		console.log(_encrypt_block('11000101', 8, [3, 1, 2, 4, 6, 5, 7, 8]));
	};

	return {
		ecb_encrypt: _ecb_encrypt,
		ecb_decrypt: _ecb_decrypt,
		test: test
	};
})();

var key = [3, 1, 2, 4, 6, 5, 7, 8], length = 8, plaintext = '0110110111000101',
codeword = MyCrypto.ecb_encrypt(plaintext, length, key),
decryptedCodeword = MyCrypto.ecb_decrypt(codeword, length, key);

console.log('Plaintext is: ' + plaintext);
console.log('Codeword is: ' + codeword);
console.log('Decrypted codeword is: ' + decryptedCodeword);

if(plaintext === decryptedCodeword) {
	console.log('The de/encryption worked perfectly');
}
else {
	console.log('The de/encryption failed');
}


MyCrypto.test();
