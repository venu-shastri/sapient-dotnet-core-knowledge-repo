import React from 'react';
import TestRenderer from 'react-test-renderer';
import {CardList} from './CardList'
import {Cards} from './Cards'

describe('CardList', ()=>{

    describe('rendering', ()=>{

        describe('selection', ()=>{

            describe('all selected', ()=> {
                it('should select all the Cards', ()=>{
                    const all = {ICICI: true, HDFC: true, SBI: true};
                    const tr = TestRenderer.create(
                    <CardList cardsActive={all} cards={Cards}  onCardSelection={()=>{}} />);
                    const inputs = tr.root.findAllByProps({"data-testid": 'card-selected'});
                    inputs.forEach((input) => {
                        expect(input.props.checked).toBe(true);
                    });
                });
            });

            describe('None selected', ()=> {
                it('should select no Cards', ()=>{
                    const all = {ICICI: false, HDFC: false, SBI: false};
                    const tr = TestRenderer.create(<CardList cardsActive={all} cards={Cards}  onCardSelection={()=>{}} />);
                    const inputs = tr.root.findAllByProps({"data-testid": 'card-selected'});
                    inputs.forEach((input) => {
                        expect(input.props.checked).toBe(false);
                    });
                });
            });
         

        });

        
        describe('activation', ()=>{
            const inactiveCssClassExpression = /.*CardSelector-inactive/;
            const cardDivPrefix = 'card-div-';

            describe('all active', ()=>{
                it('should not have the inactive class', ()=>{
                    const all = {ICICI: true, HDFC: true, SBI: true};
                    const tr = TestRenderer.create(<CardList cardsActive={all} cards={Cards}  onCardSelection={()=>{}} />);
                    const divs = tr.root.findAll((instance) => (instance.props['data-testid'] || "").startsWith(cardDivPrefix));
                    divs.forEach((div) => {
                        expect(div.props.className).not.toMatch(inactiveCssClassExpression);
                    });
                });
            });

            describe('all inactive', ()=>{
                it('should have the inactive class', ()=>{
                    const all = {ICICI: true, HDFC: true, SBI: true};
                    const tr = TestRenderer.create(<CardList cardsActive={all} cards={Cards}  onCardSelection={()=>{}} />);
                    const divs = tr.root.findAll((instance) => (instance.props['data-testid'] || "").startsWith(cardDivPrefix));
                    divs.forEach((div) => {
                        expect(div.props.className).toMatch(inactiveCssClassExpression);
                    });
                });
            });

            describe('mixed', ()=>{
                it('should have the inactive class for inactive Cards', ()=>{
                    const activation:any = {ICICI: false, HDFC: true, SBI: true};
                     const tr = TestRenderer.create(<CardList cardsActive={activation} cards={Cards}  onCardSelection={()=>{}} />);
                   
                   
                    Object.keys(activation).forEach((cardName:any) => {
                        const div = tr.root.findAll((instance) => (instance.props['data-testid'] || "") === (cardDivPrefix + cardName))[0];
                        if (activation[cardName]) {
                            expect(div.props.className).not.toMatch(inactiveCssClassExpression);
                        } else {
                            expect(div.props.className).toMatch(inactiveCssClassExpression);
                        }
                    });
                });
            });
        });
    });
});