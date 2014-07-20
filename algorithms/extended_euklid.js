function extendedEuklid(a, b, c, q, x, y) {
	var t = parseInt(a/b),
	r = a%b, xk, yk, lq;

	if(c === undefined) {
		console.log('\ngcd(a, b) = ax + by');
		console.log('a = ' + a + ' b = ' + b + '\n');
		console.log('k:\t rk: \t qk: \t xk: \t yk: \t');
		var x = [1, 0],
		y = [0, 1],
		q = ['', t];
		console.log(0 + '\t ' + a + '\t ' + q[0] + '\t ' + x[0] + '\t ' + y[0] + '\t');
		console.log(1 + '\t ' + b + '\t ' + q[1] + '\t ' + x[1] + '\t ' + y[1] + '\t');
	 	c = 1;
	}
	
	c++;

	if(r > 0) {
		lq = q[c-1];

		xk = lq * x[c-1] + x[c-2];
		yk = lq * y[c-1] + y[c-2];

		a = b;
		b = r;
		x.push(xk);
		y.push(yk);
		q[c] = parseInt(a/b);
		console.log(c + '\t ' + r + '\t ' + q[c] + '\t ' + xk + '\t ' + yk + '\t');
		return extendedEuklid(a, b, c, q, x, y);
	}
	else {
		x = Math.pow(-1, c-1) * x[c-1];
		y = Math.pow(-1, c) * y[c-1];

		return {gcd: b, x: x, y: y};
	}
}

var a = 273, b = 238;
gcd = extendedEuklid(a, b);

console.log('\ngcd(' + a + ', ' + b + ') = ' + gcd.gcd);
console.log('gcd(' + a + ', ' + b + ') = ' + '' + gcd.x + ' * ' + a + ' + ' + gcd.y + ' * ' + b );
console.log('x = ' + gcd.x + ' y = '+ gcd.y + '\n');