describe('template spec', () => {
    it('Should_create_customerconfig', () => {
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

        cy.visit('https://localhost:7021/customerconfigpage')
        cy.url().should('include', '/customerconfigpage')

        cy.wait(2000)

        cy.get('#name', { timeout: 20000 }).should('be.visible').and('not.be.disabled').type('cypressbedrijf')
        cy.get('#kvk', { timeout: 20000 }).should('be.visible').and('not.be.disabled').type('123456')
        cy.get('#btw', { timeout: 20000 }).should('be.visible').and('not.be.disabled').type('btw1234')
        cy.get('#accountnumber', { timeout: 20000 }).should('be.visible').and('not.be.disabled').type('nl1234ingb2232')
        cy.get('#firstname', { timeout: 20000 }).should('be.visible').and('not.be.disabled').type('patrick')
        cy.get('#lastname', { timeout: 20000 }).should('be.visible').and('not.be.disabled').type('hternaam')
        cy.get('#phonenumber', { timeout: 20000 }).should('be.visible').and('not.be.disabled').type('06234567')
        cy.get('#email', { timeout: 20000 }).should('be.visible').and('not.be.disabled').type('email@email.com')
        cy.get('#postalcode', { timeout: 20000 }).should('be.visible').and('not.be.disabled').type('2729 GB')
        cy.get('#housenumber', { timeout: 20000 }).should('be.visible').and('not.be.disabled').type('12')

        cy.wait(2000)

        for (let i = 0; i < 3; i++) {
            cy.get('#next', { timeout: 10000 }).should('be.visible').click()
            cy.wait(1000)
        }
    })
})