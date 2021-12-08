describe('Testing game table and dice throwing', () => {
  it('Checking if the game table has all tiles', () => {
    cy.visit('/');
    cy.get('.mat-grid-list').find('mat-grid-tile').its('length').should('eq', 121)
  })

  it('Checking if all players\' name are visible', () => {
    cy.visit('/');
    cy.get('.player-1-info-card').contains('Player 1')
    cy.get('.player-2-info-card').contains('Player 2')
    cy.get('.player-3-info-card').contains('Player 3')
    cy.get('.player-4-info-card').contains('Player 4')
  })

    it('Checking if all players\' properties are visible', () => {
    cy.visit('/');
    cy.get('.player-1-info-card').contains('Property 1')
    cy.get('.player-1-info-card').contains('Property 2')
    cy.get('.player-1-info-card').contains('Property 3')

    cy.get('.player-2-info-card').contains('Property 1')
    cy.get('.player-2-info-card').contains('Property 2')
    cy.get('.player-2-info-card').contains('Property 3')

    cy.get('.player-3-info-card').contains('Property 2')
    cy.get('.player-3-info-card').contains('Property 3')

    cy.get('.player-4-info-card').contains('Property 1')
    cy.get('.player-4-info-card').contains('Property 2')
    cy.get('.player-4-info-card').contains('Property 3')
  })

  it('Checking if all players\' money are visible', () => {
    cy.visit('/');
    cy.get('.player-1-info-card').contains('$ 505000')
    cy.get('.player-2-info-card').contains('$ 5000000')
    cy.get('.player-3-info-card').contains('$ 500000')
    cy.get('.player-4-info-card').contains('$ 5000000')
  })

  it('Checking if Player 1 starts the game', () => {
    cy.visit('/');
    cy.get('.player-1-info-card').contains('Open menu')
    cy.get('.player-2-info-card').contains('Open menu').should('not.exist')
    cy.get('.player-3-info-card').contains('Open menu').should('not.exist')
    cy.get('.player-4-info-card').contains('Open menu').should('not.exist')
  })

  it('Test dice rolling', () => {
    cy.visit('/');
    cy.get('.player-1-info-card').contains('Open menu').click()
    cy.get('.dice-roll').contains('Roll').click()
    cy.get('.dice-roll').contains('Roll').should('be.disabled')
    cy.get('.result').should('be.visible')
    cy.get('.result2').should('be.visible')
  })

  it('Test if can pass the turn and close the menu', () => {
    cy.visit('/');
    cy.get('.player-1-info-card').contains('Open menu').click()
    cy.get('.dice-roll').contains('Roll').click()
    cy.get('.player-turn').contains('Next player').click()
    cy.get('.player-turn').contains('Next player').click()
    cy.get('.player-turn').contains('Player 3')
    cy.get('.player-turn').contains('Close').click()
    cy.get('.player-turn').should('not.exist')
  })
})
