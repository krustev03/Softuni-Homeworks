let Repository = require("./solution.js");
let assert = require("chai").assert;

describe("MyTests", () => {
    describe('constructor', () => 
    {
        it('creation', () => 
        {
            let parser = new Repository('[ {"Nancy":"architect"},{"John":"developer"}]');
            assert.deepEqual(parser._data, [{"Nancy": "architect"}, {"John": "developer"}]);
            assert.deepEqual(parser._log, []);
            assert.deepEqual(parser.nextId.toString(), 'function () {\r\n            return id++;\r\n        }');
        });
    });
    describe('data getter', () => 
    {
        it('correct', () => 
        {
            let parser = new Parser('[ {"Nancy":"architect"},{"John":"developer"}]');
            assert.deepEqual(parser.data, [{"Nancy": "architect"}, {"John": "developer"}]);
        });
    });
    describe('print func', () => 
    {
        it('correct', () => 
        {
            let parser = new Parser('[ {"Nancy":"architect"},{"John":"developer"}]');
            assert.deepEqual(parser.print(), 'id|name|position\n0|Nancy|architect\n1|John|developer');
            assert.deepEqual(parser._log.length, 1);
        });
    });
    describe('addEntries func', () => 
    {
        it('correct', () => 
        {
            let parser = new Parser('[ {"Nancy":"architect"},{"John":"developer"}]');
            assert.deepEqual(parser.addEntries("Steven:tech-support Edd:administrator"), 
            "Entries added!");
            assert.deepEqual(parser._data, [{ Nancy: 'architect' },
            { John: 'developer' },
            { Steven: 'tech-support' },
            { Edd: 'administrator' }])
        });
    });
    describe('removeEntry func', () => 
    {
        it('correct', () => 
        {
            let parser = new Parser('[ {"Nancy":"architect"},{"John":"developer"}]');
            assert.deepEqual(parser.removeEntry("John"), "Removed correctly!");
            assert.deepEqual(parser._data, [{ "Nancy": "architect" },
            { "John": "developer",
              "deleted": true}]);
        });
        it('not correct', () => 
        {
            let parser = new Parser('[ {"Nancy":"architect"},{"John":"developer"}]');
            assert.throws(() => parser.removeEntry("Katy"), "There is no such entry!");
        });
    });
});