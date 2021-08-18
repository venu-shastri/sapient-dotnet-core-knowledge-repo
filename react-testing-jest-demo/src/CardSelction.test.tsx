import React from 'react';
import ReactDOM from 'react-dom';
import ReactTestUtils from 'react-dom/test-utils';


describe('CardSelection', () => {

    describe('rendering', () => {
        let container:any,select:any;
        const cards:any = {
            CC: "Credit Cards",
            DC: "Debit Cards"
        };
        beforeEach(() => {
            container = document.createElement('div');
            document.body.appendChild(container);
            ReactTestUtils.act(()=>{
                ReactDOM.render(<CardSelection card="CC" crds={cards} onCardSelected={()=>{}} />, container);
            });
            select = container.querySelector('select');
          });
          
          afterEach(() => {
            document.body.removeChild(container);
            container = null;
          });

        it("should render a select element", () => {
            expect(select).toBeDefined();
        });
        it("should have 2 options", ()=>{
            expect(select.length).toBe(2);
        });
        it("should have CC (Credit Card) selected", ()=>{
            expect(select.value).toBe("CC");
            expect(select.selectedOptions[0].text).toBe('Credit Card');
        });
    });
});