describe('My First Test', () => {
  it('Visits the initial project page', () => {
    cy.visit('/')
    cy.contains('Player 1')
    cy.contains('Player\'s porperties')
  })
})
