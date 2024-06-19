describe('template spec', () => {
    it('view customer config', () => {
        cy.visit('https://localhost:7021/signIn')

        cy.url().should('include', '/signIn')

        cy.get('#input-password', { timeout: 20000 }).should('be.visible').and('not.be.disabled').type('Admin@123')

        cy.wait(2000)

        cy.get('#email', { timeout: 10000 }).should('be.visible').type('admin@admin.com')

        cy.wait(2000)

        cy.get('#login-submit', { timeout: 10000 }).should('be.visible').click({ force: true })

        cy.url().should('not.include', '/signIn')

        cy.visit('https://localhost:7021/contract')
        cy.url().should('include', '/contract')

        cy.visit('https://localhost:7021/Customer')
        cy.url().should('include', '/Customer')

        cy.wait(2000)

        cy.get('#delete', { timeout: 10000 }).should('be.visible').click()

        
    })
})
