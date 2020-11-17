const assert = require('chai').assert;
const { describe } = require('mocha');
const exercise = require('../exercise');

describe('testcase for js',function(){
    it('this returns hello',function(){
        let actualResult=exercise.first();
        let expectedResult='hello';
        assert.equal(actualResult,expectedResult);
    })
    it('a string',function(){
        let actualResult=exercise.first();
        let expectedResult="string";
        assert.typeOf(actualResult,expectedResult);
    })
    it('null',function(){
        let actualResult=exercise.second();
        assert.notExists(actualResult);
    })
    it('division',function(){
        let actualResult=exercise.division(6,3);
        let expectedResult=2;
        assert.strictEqual(actualResult,expectedResult);
    })
    it('a number',function(){
        let actualResult=exercise.division(6,3);
        let expectedResult="number";
        assert.typeOf(actualResult,expectedResult);
    })
    
    xit('invalid arguement',function(){
        let actualResult=exercise.division(a,b);
        //let expectedResult="invalid arguement";
        assert.isNaN(actualResult);
    })
});